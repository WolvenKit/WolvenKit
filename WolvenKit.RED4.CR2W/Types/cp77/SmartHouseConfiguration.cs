using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartHouseConfiguration : CVariable
	{
		private CBool _enableInteraction;
		private CName _factName;

		[Ordinal(0)] 
		[RED("enableInteraction")] 
		public CBool EnableInteraction
		{
			get => GetProperty(ref _enableInteraction);
			set => SetProperty(ref _enableInteraction, value);
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		public SmartHouseConfiguration(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
