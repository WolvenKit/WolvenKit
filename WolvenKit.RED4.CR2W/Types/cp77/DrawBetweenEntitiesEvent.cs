using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrawBetweenEntitiesEvent : redEvent
	{
		private CBool _shouldDraw;
		private gameFxResource _fxResource;
		private CBool _revealMaster;
		private CBool _revealSlave;
		private entEntityID _masterEntity;
		private entEntityID _slaveEntity;

		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get
			{
				if (_shouldDraw == null)
				{
					_shouldDraw = (CBool) CR2WTypeManager.Create("Bool", "shouldDraw", cr2w, this);
				}
				return _shouldDraw;
			}
			set
			{
				if (_shouldDraw == value)
				{
					return;
				}
				_shouldDraw = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get
			{
				if (_fxResource == null)
				{
					_fxResource = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "fxResource", cr2w, this);
				}
				return _fxResource;
			}
			set
			{
				if (_fxResource == value)
				{
					return;
				}
				_fxResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get
			{
				if (_revealMaster == null)
				{
					_revealMaster = (CBool) CR2WTypeManager.Create("Bool", "revealMaster", cr2w, this);
				}
				return _revealMaster;
			}
			set
			{
				if (_revealMaster == value)
				{
					return;
				}
				_revealMaster = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get
			{
				if (_revealSlave == null)
				{
					_revealSlave = (CBool) CR2WTypeManager.Create("Bool", "revealSlave", cr2w, this);
				}
				return _revealSlave;
			}
			set
			{
				if (_revealSlave == value)
				{
					return;
				}
				_revealSlave = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("masterEntity")] 
		public entEntityID MasterEntity
		{
			get
			{
				if (_masterEntity == null)
				{
					_masterEntity = (entEntityID) CR2WTypeManager.Create("entEntityID", "masterEntity", cr2w, this);
				}
				return _masterEntity;
			}
			set
			{
				if (_masterEntity == value)
				{
					return;
				}
				_masterEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("slaveEntity")] 
		public entEntityID SlaveEntity
		{
			get
			{
				if (_slaveEntity == null)
				{
					_slaveEntity = (entEntityID) CR2WTypeManager.Create("entEntityID", "slaveEntity", cr2w, this);
				}
				return _slaveEntity;
			}
			set
			{
				if (_slaveEntity == value)
				{
					return;
				}
				_slaveEntity = value;
				PropertySet(this);
			}
		}

		public DrawBetweenEntitiesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
