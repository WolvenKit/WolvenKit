using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldgeometryHandIKDescriptionResult : CVariable
	{
		private Vector4 _grabPointStart;
		private Vector4 _grabPointEnd;

		[Ordinal(0)] 
		[RED("grabPointStart")] 
		public Vector4 GrabPointStart
		{
			get => GetProperty(ref _grabPointStart);
			set => SetProperty(ref _grabPointStart, value);
		}

		[Ordinal(1)] 
		[RED("grabPointEnd")] 
		public Vector4 GrabPointEnd
		{
			get => GetProperty(ref _grabPointEnd);
			set => SetProperty(ref _grabPointEnd, value);
		}

		public worldgeometryHandIKDescriptionResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
