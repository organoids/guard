namespace Organoids.Guard
{
    public class Guard
    {
        /// <summary>
        /// Guard for string.
        /// </summary>
        public static IStringGuard String { get; } = new StringGuard();

        /// <summary>
        /// Guard for int.
        /// </summary>
        public static IIntGuard Int { get; } = new IntGuard();
    }

    internal class StringGuard : IStringGuard
    {
        internal StringGuard() { }
    }

    internal class IntGuard : IIntGuard
    {
        internal IntGuard() { }
    }
}
