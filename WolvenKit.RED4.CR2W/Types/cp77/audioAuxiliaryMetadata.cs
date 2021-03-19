using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAuxiliaryMetadata : CVariable
	{
		private CName _physicalPropSettings;

		[Ordinal(0)] 
		[RED("physicalPropSettings")] 
		public CName PhysicalPropSettings
		{
			get => GetProperty(ref _physicalPropSettings);
			set => SetProperty(ref _physicalPropSettings, value);
		}

		public audioAuxiliaryMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
