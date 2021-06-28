using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsNotifyFootstepMaterialContextChanged : redEvent
	{
		private CName _footwareType;
		private CName _surfaceFlavourName;

		[Ordinal(0)] 
		[RED("footwareType")] 
		public CName FootwareType
		{
			get => GetProperty(ref _footwareType);
			set => SetProperty(ref _footwareType, value);
		}

		[Ordinal(1)] 
		[RED("surfaceFlavourName")] 
		public CName SurfaceFlavourName
		{
			get => GetProperty(ref _surfaceFlavourName);
			set => SetProperty(ref _surfaceFlavourName, value);
		}

		public gameaudioeventsNotifyFootstepMaterialContextChanged(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
