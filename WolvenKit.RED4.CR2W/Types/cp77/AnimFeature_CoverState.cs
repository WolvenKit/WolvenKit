using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CoverState : animAnimFeature
	{
		private CBool _inCover;
		private CBool _debugVar;

		[Ordinal(0)] 
		[RED("inCover")] 
		public CBool InCover
		{
			get
			{
				if (_inCover == null)
				{
					_inCover = (CBool) CR2WTypeManager.Create("Bool", "inCover", cr2w, this);
				}
				return _inCover;
			}
			set
			{
				if (_inCover == value)
				{
					return;
				}
				_inCover = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("debugVar")] 
		public CBool DebugVar
		{
			get
			{
				if (_debugVar == null)
				{
					_debugVar = (CBool) CR2WTypeManager.Create("Bool", "debugVar", cr2w, this);
				}
				return _debugVar;
			}
			set
			{
				if (_debugVar == value)
				{
					return;
				}
				_debugVar = value;
				PropertySet(this);
			}
		}

		public AnimFeature_CoverState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
