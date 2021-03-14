using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTier_NodeType : questISceneManagerNodeType
	{
		private CEnum<GameplayTier> _tier;
		private CBool _usePlayerWorkspot;
		private CBool _useEnterAnim;
		private CBool _useExitAnim;
		private CBool _forceEmptyHands;

		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get
			{
				if (_tier == null)
				{
					_tier = (CEnum<GameplayTier>) CR2WTypeManager.Create("GameplayTier", "tier", cr2w, this);
				}
				return _tier;
			}
			set
			{
				if (_tier == value)
				{
					return;
				}
				_tier = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("usePlayerWorkspot")] 
		public CBool UsePlayerWorkspot
		{
			get
			{
				if (_usePlayerWorkspot == null)
				{
					_usePlayerWorkspot = (CBool) CR2WTypeManager.Create("Bool", "usePlayerWorkspot", cr2w, this);
				}
				return _usePlayerWorkspot;
			}
			set
			{
				if (_usePlayerWorkspot == value)
				{
					return;
				}
				_usePlayerWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useEnterAnim")] 
		public CBool UseEnterAnim
		{
			get
			{
				if (_useEnterAnim == null)
				{
					_useEnterAnim = (CBool) CR2WTypeManager.Create("Bool", "useEnterAnim", cr2w, this);
				}
				return _useEnterAnim;
			}
			set
			{
				if (_useEnterAnim == value)
				{
					return;
				}
				_useEnterAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useExitAnim")] 
		public CBool UseExitAnim
		{
			get
			{
				if (_useExitAnim == null)
				{
					_useExitAnim = (CBool) CR2WTypeManager.Create("Bool", "useExitAnim", cr2w, this);
				}
				return _useExitAnim;
			}
			set
			{
				if (_useExitAnim == value)
				{
					return;
				}
				_useExitAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forceEmptyHands")] 
		public CBool ForceEmptyHands
		{
			get
			{
				if (_forceEmptyHands == null)
				{
					_forceEmptyHands = (CBool) CR2WTypeManager.Create("Bool", "forceEmptyHands", cr2w, this);
				}
				return _forceEmptyHands;
			}
			set
			{
				if (_forceEmptyHands == value)
				{
					return;
				}
				_forceEmptyHands = value;
				PropertySet(this);
			}
		}

		public questSetTier_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
