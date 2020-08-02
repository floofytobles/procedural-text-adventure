
abstract class Either<L, R>{
	private Either(){}

	public sealed class Left : Either<L, R>{
		public Left(L value) => Value = value;
		public L Value { get; }
	}

	public sealed class Right : Either<L, R>{
		public Right(R value) => Value = value;
		public R Value { get; }
	}
}
