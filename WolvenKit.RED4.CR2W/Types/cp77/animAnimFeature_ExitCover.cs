using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_ExitCover : animAnimFeature_AIAction
	{
		private CInt32 _coverStance;
		private CInt32 _coverExitDirection;

		[Ordinal(4)] 
		[RED("coverStance")] 
		public CInt32 CoverStance
		{
			get
			{
				if (_coverStance == null)
				{
					_coverStance = (CInt32) CR2WTypeManager.Create("Int32", "coverStance", cr2w, this);
				}
				return _coverStance;
			}
			set
			{
				if (_coverStance == value)
				{
					return;
				}
				_coverStance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("coverExitDirection")] 
		public CInt32 CoverExitDirection
		{
			get
			{
				if (_coverExitDirection == null)
				{
					_coverExitDirection = (CInt32) CR2WTypeManager.Create("Int32", "coverExitDirection", cr2w, this);
				}
				return _coverExitDirection;
			}
			set
			{
				if (_coverExitDirection == value)
				{
					return;
				}
				_coverExitDirection = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_ExitCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
