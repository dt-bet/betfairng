namespace BetfairNG
{
    public enum Direction
    {
        Up, Down
    }

    public struct Price
    {
        public const decimal Factor = 100m;

        public Price(decimal value, Direction roundDirection = Direction.Up)
        {
            this.Direction = roundDirection;
            this.Value = roundDirection == Direction.Up ?
                PriceHelpers.RoundUpToNearestBetfairPrice(value) :
                PriceHelpers.RoundDownToNearestBetfairPrice(value);
        }

        public Price(int value, Direction roundDirection = Direction.Up)
        {
            this.Direction = roundDirection;
            this.Value = roundDirection == Direction.Up ?
                PriceHelpers.RoundUpToNearestBetfairPrice(value/Factor) :
                PriceHelpers.RoundDownToNearestBetfairPrice(value/Factor);
        }

        public Direction Direction { get; }

        public decimal Value { get; }

        public static implicit operator int(Price d) => (int)(d.Value * Factor);

        public static implicit operator Price(int d) => new Price(d / Factor);

        public Price AddPip() => new Price(PriceHelpers.AddPip(Value), Direction);


        public Price AddPip(int num) => new Price(PriceHelpers.AddPip(Value, num), Direction);


        public Price SubtractPip() => new Price(PriceHelpers.SubtractPip(Value), Direction);


        public Price SubtractPip(int num) => new Price(PriceHelpers.SubtractPip(num), Direction);


        public Price ApplySpread(double percentage) => new Price(PriceHelpers.ApplySpread(Value, percentage), Direction);


        public Price WithDirection(Direction direction) => new Price(Value, direction);
    }
}