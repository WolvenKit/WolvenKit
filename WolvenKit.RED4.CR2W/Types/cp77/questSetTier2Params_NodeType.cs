using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTier2Params_NodeType : questISceneManagerNodeType
	{
		private CEnum<Tier2WalkType> _playerWalkType;
		private CBool _usePlayerWorkspot;
		private CBool _useEnterAnim;
		private CBool _useExitAnim;

		[Ordinal(0)] 
		[RED("playerWalkType")] 
		public CEnum<Tier2WalkType> PlayerWalkType
		{
			get
			{
				if (_playerWalkType == null)
				{
					_playerWalkType = (CEnum<Tier2WalkType>) CR2WTypeManager.Create("Tier2WalkType", "playerWalkType", cr2w, this);
				}
				return _playerWalkType;
			}
			set
			{
				if (_playerWalkType == value)
				{
					return;
				}
				_playerWalkType = value;
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

		public questSetTier2Params_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
