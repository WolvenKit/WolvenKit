using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIsMovingPrereq : GenericHitPrereq
	{
		private CBool _isMoving;
		private CString _object;

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

		public HitIsMovingPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
