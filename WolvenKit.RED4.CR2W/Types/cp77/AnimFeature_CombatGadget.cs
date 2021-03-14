using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CombatGadget : animAnimFeature
	{
		private CBool _isQuickthrow;
		private CBool _isDetonated;

		[Ordinal(0)] 
		[RED("isQuickthrow")] 
		public CBool IsQuickthrow
		{
			get
			{
				if (_isQuickthrow == null)
				{
					_isQuickthrow = (CBool) CR2WTypeManager.Create("Bool", "isQuickthrow", cr2w, this);
				}
				return _isQuickthrow;
			}
			set
			{
				if (_isQuickthrow == value)
				{
					return;
				}
				_isQuickthrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isDetonated")] 
		public CBool IsDetonated
		{
			get
			{
				if (_isDetonated == null)
				{
					_isDetonated = (CBool) CR2WTypeManager.Create("Bool", "isDetonated", cr2w, this);
				}
				return _isDetonated;
			}
			set
			{
				if (_isDetonated == value)
				{
					return;
				}
				_isDetonated = value;
				PropertySet(this);
			}
		}

		public AnimFeature_CombatGadget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
