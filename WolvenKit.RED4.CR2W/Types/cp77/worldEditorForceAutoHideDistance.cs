using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEditorForceAutoHideDistance : ISerializable
	{
		private CFloat _minAutoHideDistance;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("minAutoHideDistance")] 
		public CFloat MinAutoHideDistance
		{
			get => GetProperty(ref _minAutoHideDistance);
			set => SetProperty(ref _minAutoHideDistance, value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}

		public worldEditorForceAutoHideDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
