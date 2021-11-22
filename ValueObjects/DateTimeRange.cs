namespace LuPerfect.Domain.ValueObjects
{
    public record DateTimeRange : ValueObject
    {
        public DateTime StartDate { get; }
        public DateTime? EndDate { get; }

        public DateTimeRange(DateTime startDate, DateTime? endDate)
        {
            if (startDate > endDate)
                throw new ArgumentException("Конечная дата не может быть раньше даты начала.");

            StartDate = startDate;
            EndDate = endDate;
        }

        public DateTimeRange UpdateStartDate(DateTime startDate) => new(startDate, EndDate);
        public DateTimeRange UpdateEndDate(DateTime endDate) => new(StartDate, endDate);

        public int ToDays(DateTime? endDateToUseIfMissing = null)
        {
            var end = EndDate ?? endDateToUseIfMissing ?? DateTime.UtcNow;

            return (end - StartDate).Days;
        }

        public int ToDaysInRangeThroughPeriodEndDate(DateTime periodEndDate)
        {
            if (EndDate.HasValue && EndDate.Value <= periodEndDate)
                return ToDays(EndDate.Value);

            return (periodEndDate - StartDate).Days;
        }

        public bool Contains(DateTime date) => StartDate <= date && date <= EndDate;

        public override string ToString() => $"{StartDate.ToShortDateString()}-{EndDate?.ToShortDateString() ?? "∞"}";
    }
}
