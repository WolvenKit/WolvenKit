using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpotPersistentData : CVariable
	{
		private WorldTransform _worldTransform;
		private worldGlobalNodeID _globalNodeId;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("worldTransform")] 
		public WorldTransform WorldTransform
		{
			get
			{
				if (_worldTransform == null)
				{
					_worldTransform = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "worldTransform", cr2w, this);
				}
				return _worldTransform;
			}
			set
			{
				if (_worldTransform == value)
				{
					return;
				}
				_worldTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("globalNodeId")] 
		public worldGlobalNodeID GlobalNodeId
		{
			get
			{
				if (_globalNodeId == null)
				{
					_globalNodeId = (worldGlobalNodeID) CR2WTypeManager.Create("worldGlobalNodeID", "globalNodeId", cr2w, this);
				}
				return _globalNodeId;
			}
			set
			{
				if (_globalNodeId == value)
				{
					return;
				}
				_globalNodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public AISpotPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
