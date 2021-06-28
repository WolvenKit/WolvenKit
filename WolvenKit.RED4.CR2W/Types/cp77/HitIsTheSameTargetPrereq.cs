using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIsTheSameTargetPrereq : GenericHitPrereq
	{
		private CBool _isMoving;
		private CString _object;
		private CBool _invert;

		[Ordinal(5)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetProperty(ref _isMoving);
			set => SetProperty(ref _isMoving, value);
		}

		[Ordinal(6)] 
		[RED("object")] 
		public CString Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		[Ordinal(7)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public HitIsTheSameTargetPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
