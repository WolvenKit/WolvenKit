using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Puppet : questTimeDilation_NodeTypeParam
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

		public questTimeDilation_Puppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
