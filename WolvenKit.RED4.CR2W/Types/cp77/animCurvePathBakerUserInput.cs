using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCurvePathBakerUserInput : CVariable
	{
		private CName _controllersSetupName;
		private CBool _useStart;
		private CBool _useStop;
		private CFloat _blendTime;

		[Ordinal(0)] 
		[RED("controllersSetupName")] 
		public CName ControllersSetupName
		{
			get => GetProperty(ref _controllersSetupName);
			set => SetProperty(ref _controllersSetupName, value);
		}

		[Ordinal(1)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(2)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(3)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		public animCurvePathBakerUserInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
