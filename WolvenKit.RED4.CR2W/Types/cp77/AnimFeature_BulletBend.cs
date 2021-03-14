using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_BulletBend : animAnimFeature
	{
		private CFloat _animProgression;
		private CFloat _randomAdditive;
		private CBool _isResetting;

		[Ordinal(0)] 
		[RED("animProgression")] 
		public CFloat AnimProgression
		{
			get
			{
				if (_animProgression == null)
				{
					_animProgression = (CFloat) CR2WTypeManager.Create("Float", "animProgression", cr2w, this);
				}
				return _animProgression;
			}
			set
			{
				if (_animProgression == value)
				{
					return;
				}
				_animProgression = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("randomAdditive")] 
		public CFloat RandomAdditive
		{
			get
			{
				if (_randomAdditive == null)
				{
					_randomAdditive = (CFloat) CR2WTypeManager.Create("Float", "randomAdditive", cr2w, this);
				}
				return _randomAdditive;
			}
			set
			{
				if (_randomAdditive == value)
				{
					return;
				}
				_randomAdditive = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isResetting")] 
		public CBool IsResetting
		{
			get
			{
				if (_isResetting == null)
				{
					_isResetting = (CBool) CR2WTypeManager.Create("Bool", "isResetting", cr2w, this);
				}
				return _isResetting;
			}
			set
			{
				if (_isResetting == value)
				{
					return;
				}
				_isResetting = value;
				PropertySet(this);
			}
		}

		public AnimFeature_BulletBend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
