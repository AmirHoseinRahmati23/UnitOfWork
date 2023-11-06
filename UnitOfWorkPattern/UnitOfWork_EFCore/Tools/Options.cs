using UnitOfWork_EFCore.Tools.Enums;

namespace UnitOfWork_EFCore.Tools
{
	public class Options : object
	{
		public Options() : base()
		{
		}

		public Provider Provider { get; set; }

		public string? ConnectionString { get; set; }
	}
}
