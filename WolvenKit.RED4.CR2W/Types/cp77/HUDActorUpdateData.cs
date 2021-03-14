using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDActorUpdateData : IScriptable
	{
		private CBool _updateVisibility;
		private CEnum<ActorVisibilityStatus> _visibilityValue;
		private CBool _updateIsRevealed;
		private CBool _isRevealedValue;
		private CBool _updateIsTagged;
		private CBool _isTaggedValue;
		private CBool _updateClueData;
		private HUDClueData _clueDataValue;
		private CBool _updateIsRemotelyAccessed;
		private CBool _isRemotelyAccessedValue;
		private CBool _updateCanOpenScannerInfo;
		private CBool _canOpenScannerInfoValue;
		private CBool _updateIsInIconForcedVisibilityRange;
		private CBool _isInIconForcedVisibilityRangeValue;
		private CBool _updateIsIconForcedVisibleThroughWalls;
		private CBool _isIconForcedVisibleThroughWallsValue;

		[Ordinal(0)] 
		[RED("updateVisibility")] 
		public CBool UpdateVisibility
		{
			get
			{
				if (_updateVisibility == null)
				{
					_updateVisibility = (CBool) CR2WTypeManager.Create("Bool", "updateVisibility", cr2w, this);
				}
				return _updateVisibility;
			}
			set
			{
				if (_updateVisibility == value)
				{
					return;
				}
				_updateVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visibilityValue")] 
		public CEnum<ActorVisibilityStatus> VisibilityValue
		{
			get
			{
				if (_visibilityValue == null)
				{
					_visibilityValue = (CEnum<ActorVisibilityStatus>) CR2WTypeManager.Create("ActorVisibilityStatus", "visibilityValue", cr2w, this);
				}
				return _visibilityValue;
			}
			set
			{
				if (_visibilityValue == value)
				{
					return;
				}
				_visibilityValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("updateIsRevealed")] 
		public CBool UpdateIsRevealed
		{
			get
			{
				if (_updateIsRevealed == null)
				{
					_updateIsRevealed = (CBool) CR2WTypeManager.Create("Bool", "updateIsRevealed", cr2w, this);
				}
				return _updateIsRevealed;
			}
			set
			{
				if (_updateIsRevealed == value)
				{
					return;
				}
				_updateIsRevealed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isRevealedValue")] 
		public CBool IsRevealedValue
		{
			get
			{
				if (_isRevealedValue == null)
				{
					_isRevealedValue = (CBool) CR2WTypeManager.Create("Bool", "isRevealedValue", cr2w, this);
				}
				return _isRevealedValue;
			}
			set
			{
				if (_isRevealedValue == value)
				{
					return;
				}
				_isRevealedValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("updateIsTagged")] 
		public CBool UpdateIsTagged
		{
			get
			{
				if (_updateIsTagged == null)
				{
					_updateIsTagged = (CBool) CR2WTypeManager.Create("Bool", "updateIsTagged", cr2w, this);
				}
				return _updateIsTagged;
			}
			set
			{
				if (_updateIsTagged == value)
				{
					return;
				}
				_updateIsTagged = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isTaggedValue")] 
		public CBool IsTaggedValue
		{
			get
			{
				if (_isTaggedValue == null)
				{
					_isTaggedValue = (CBool) CR2WTypeManager.Create("Bool", "isTaggedValue", cr2w, this);
				}
				return _isTaggedValue;
			}
			set
			{
				if (_isTaggedValue == value)
				{
					return;
				}
				_isTaggedValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("updateClueData")] 
		public CBool UpdateClueData
		{
			get
			{
				if (_updateClueData == null)
				{
					_updateClueData = (CBool) CR2WTypeManager.Create("Bool", "updateClueData", cr2w, this);
				}
				return _updateClueData;
			}
			set
			{
				if (_updateClueData == value)
				{
					return;
				}
				_updateClueData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("clueDataValue")] 
		public HUDClueData ClueDataValue
		{
			get
			{
				if (_clueDataValue == null)
				{
					_clueDataValue = (HUDClueData) CR2WTypeManager.Create("HUDClueData", "clueDataValue", cr2w, this);
				}
				return _clueDataValue;
			}
			set
			{
				if (_clueDataValue == value)
				{
					return;
				}
				_clueDataValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("updateIsRemotelyAccessed")] 
		public CBool UpdateIsRemotelyAccessed
		{
			get
			{
				if (_updateIsRemotelyAccessed == null)
				{
					_updateIsRemotelyAccessed = (CBool) CR2WTypeManager.Create("Bool", "updateIsRemotelyAccessed", cr2w, this);
				}
				return _updateIsRemotelyAccessed;
			}
			set
			{
				if (_updateIsRemotelyAccessed == value)
				{
					return;
				}
				_updateIsRemotelyAccessed = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isRemotelyAccessedValue")] 
		public CBool IsRemotelyAccessedValue
		{
			get
			{
				if (_isRemotelyAccessedValue == null)
				{
					_isRemotelyAccessedValue = (CBool) CR2WTypeManager.Create("Bool", "isRemotelyAccessedValue", cr2w, this);
				}
				return _isRemotelyAccessedValue;
			}
			set
			{
				if (_isRemotelyAccessedValue == value)
				{
					return;
				}
				_isRemotelyAccessedValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("updateCanOpenScannerInfo")] 
		public CBool UpdateCanOpenScannerInfo
		{
			get
			{
				if (_updateCanOpenScannerInfo == null)
				{
					_updateCanOpenScannerInfo = (CBool) CR2WTypeManager.Create("Bool", "updateCanOpenScannerInfo", cr2w, this);
				}
				return _updateCanOpenScannerInfo;
			}
			set
			{
				if (_updateCanOpenScannerInfo == value)
				{
					return;
				}
				_updateCanOpenScannerInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("canOpenScannerInfoValue")] 
		public CBool CanOpenScannerInfoValue
		{
			get
			{
				if (_canOpenScannerInfoValue == null)
				{
					_canOpenScannerInfoValue = (CBool) CR2WTypeManager.Create("Bool", "canOpenScannerInfoValue", cr2w, this);
				}
				return _canOpenScannerInfoValue;
			}
			set
			{
				if (_canOpenScannerInfoValue == value)
				{
					return;
				}
				_canOpenScannerInfoValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("updateIsInIconForcedVisibilityRange")] 
		public CBool UpdateIsInIconForcedVisibilityRange
		{
			get
			{
				if (_updateIsInIconForcedVisibilityRange == null)
				{
					_updateIsInIconForcedVisibilityRange = (CBool) CR2WTypeManager.Create("Bool", "updateIsInIconForcedVisibilityRange", cr2w, this);
				}
				return _updateIsInIconForcedVisibilityRange;
			}
			set
			{
				if (_updateIsInIconForcedVisibilityRange == value)
				{
					return;
				}
				_updateIsInIconForcedVisibilityRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isInIconForcedVisibilityRangeValue")] 
		public CBool IsInIconForcedVisibilityRangeValue
		{
			get
			{
				if (_isInIconForcedVisibilityRangeValue == null)
				{
					_isInIconForcedVisibilityRangeValue = (CBool) CR2WTypeManager.Create("Bool", "isInIconForcedVisibilityRangeValue", cr2w, this);
				}
				return _isInIconForcedVisibilityRangeValue;
			}
			set
			{
				if (_isInIconForcedVisibilityRangeValue == value)
				{
					return;
				}
				_isInIconForcedVisibilityRangeValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("updateIsIconForcedVisibleThroughWalls")] 
		public CBool UpdateIsIconForcedVisibleThroughWalls
		{
			get
			{
				if (_updateIsIconForcedVisibleThroughWalls == null)
				{
					_updateIsIconForcedVisibleThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "updateIsIconForcedVisibleThroughWalls", cr2w, this);
				}
				return _updateIsIconForcedVisibleThroughWalls;
			}
			set
			{
				if (_updateIsIconForcedVisibleThroughWalls == value)
				{
					return;
				}
				_updateIsIconForcedVisibleThroughWalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isIconForcedVisibleThroughWallsValue")] 
		public CBool IsIconForcedVisibleThroughWallsValue
		{
			get
			{
				if (_isIconForcedVisibleThroughWallsValue == null)
				{
					_isIconForcedVisibleThroughWallsValue = (CBool) CR2WTypeManager.Create("Bool", "isIconForcedVisibleThroughWallsValue", cr2w, this);
				}
				return _isIconForcedVisibleThroughWallsValue;
			}
			set
			{
				if (_isIconForcedVisibleThroughWallsValue == value)
				{
					return;
				}
				_isIconForcedVisibleThroughWallsValue = value;
				PropertySet(this);
			}
		}

		public HUDActorUpdateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
