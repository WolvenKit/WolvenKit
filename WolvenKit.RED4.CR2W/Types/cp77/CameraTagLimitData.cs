using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraTagLimitData : IScriptable
	{
		private CBool _add;
		private wCHandle<SurveillanceCamera> _object;

		[Ordinal(0)] 
		[RED("add")] 
		public CBool Add
		{
			get => GetProperty(ref _add);
			set => SetProperty(ref _add, value);
		}

		[Ordinal(1)] 
		[RED("object")] 
		public wCHandle<SurveillanceCamera> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		public CameraTagLimitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
