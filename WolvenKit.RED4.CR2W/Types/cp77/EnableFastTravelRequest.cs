using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EnableFastTravelRequest : gameScriptableSystemRequest
	{
		private CBool _isEnabled;
		private CBool _forceRefreshUI;
		private CName _reason;
		private TweakDBID _linkedStatusEffectID;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("forceRefreshUI")] 
		public CBool ForceRefreshUI
		{
			get
			{
				if (_forceRefreshUI == null)
				{
					_forceRefreshUI = (CBool) CR2WTypeManager.Create("Bool", "forceRefreshUI", cr2w, this);
				}
				return _forceRefreshUI;
			}
			set
			{
				if (_forceRefreshUI == value)
				{
					return;
				}
				_forceRefreshUI = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reason")] 
		public CName Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CName) CR2WTypeManager.Create("CName", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("linkedStatusEffectID")] 
		public TweakDBID LinkedStatusEffectID
		{
			get
			{
				if (_linkedStatusEffectID == null)
				{
					_linkedStatusEffectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "linkedStatusEffectID", cr2w, this);
				}
				return _linkedStatusEffectID;
			}
			set
			{
				if (_linkedStatusEffectID == value)
				{
					return;
				}
				_linkedStatusEffectID = value;
				PropertySet(this);
			}
		}

		public EnableFastTravelRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
