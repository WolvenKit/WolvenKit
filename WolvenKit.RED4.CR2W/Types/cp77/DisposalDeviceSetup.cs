using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisposalDeviceSetup : CVariable
	{
		private CInt32 _numberOfUses;
		private CBool _isBodyRequired;
		private TweakDBID _actionName;
		private TweakDBID _takedownActionName;
		private TweakDBID _nonlethalTakedownActionName;

		[Ordinal(0)] 
		[RED("numberOfUses")] 
		public CInt32 NumberOfUses
		{
			get
			{
				if (_numberOfUses == null)
				{
					_numberOfUses = (CInt32) CR2WTypeManager.Create("Int32", "numberOfUses", cr2w, this);
				}
				return _numberOfUses;
			}
			set
			{
				if (_numberOfUses == value)
				{
					return;
				}
				_numberOfUses = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isBodyRequired")] 
		public CBool IsBodyRequired
		{
			get
			{
				if (_isBodyRequired == null)
				{
					_isBodyRequired = (CBool) CR2WTypeManager.Create("Bool", "isBodyRequired", cr2w, this);
				}
				return _isBodyRequired;
			}
			set
			{
				if (_isBodyRequired == value)
				{
					return;
				}
				_isBodyRequired = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("actionName")] 
		public TweakDBID ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("takedownActionName")] 
		public TweakDBID TakedownActionName
		{
			get
			{
				if (_takedownActionName == null)
				{
					_takedownActionName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "takedownActionName", cr2w, this);
				}
				return _takedownActionName;
			}
			set
			{
				if (_takedownActionName == value)
				{
					return;
				}
				_takedownActionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("nonlethalTakedownActionName")] 
		public TweakDBID NonlethalTakedownActionName
		{
			get
			{
				if (_nonlethalTakedownActionName == null)
				{
					_nonlethalTakedownActionName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "nonlethalTakedownActionName", cr2w, this);
				}
				return _nonlethalTakedownActionName;
			}
			set
			{
				if (_nonlethalTakedownActionName == value)
				{
					return;
				}
				_nonlethalTakedownActionName = value;
				PropertySet(this);
			}
		}

		public DisposalDeviceSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
