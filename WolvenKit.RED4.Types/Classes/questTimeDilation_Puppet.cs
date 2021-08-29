using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTimeDilation_Puppet : questTimeDilation_NodeTypeParam
	{
		private CHandle<questTimeDilation_Operation> _operation;
		private CEnum<questETimeDilationOverride> _globalTimeDilationOverride;
		private gameEntityReference _puppets;

		[Ordinal(0)] 
		[RED("operation")] 
		public CHandle<questTimeDilation_Operation> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(1)] 
		[RED("globalTimeDilationOverride")] 
		public CEnum<questETimeDilationOverride> GlobalTimeDilationOverride
		{
			get => GetProperty(ref _globalTimeDilationOverride);
			set => SetProperty(ref _globalTimeDilationOverride, value);
		}

		[Ordinal(2)] 
		[RED("puppets")] 
		public gameEntityReference Puppets
		{
			get => GetProperty(ref _puppets);
			set => SetProperty(ref _puppets, value);
		}
	}
}
