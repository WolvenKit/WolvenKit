using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTargetingComponent : entIPlacedComponent
	{
		private CBool _isPrimary;
		private CBool _isDirectional;
		private CArray<TweakDBID> _aimAssistData;
		private CBool _isEnabled;
		private CBool _alwaysInTestRange;

		[Ordinal(5)] 
		[RED("isPrimary")] 
		public CBool IsPrimary
		{
			get
			{
				if (_isPrimary == null)
				{
					_isPrimary = (CBool) CR2WTypeManager.Create("Bool", "isPrimary", cr2w, this);
				}
				return _isPrimary;
			}
			set
			{
				if (_isPrimary == value)
				{
					return;
				}
				_isPrimary = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isDirectional")] 
		public CBool IsDirectional
		{
			get
			{
				if (_isDirectional == null)
				{
					_isDirectional = (CBool) CR2WTypeManager.Create("Bool", "isDirectional", cr2w, this);
				}
				return _isDirectional;
			}
			set
			{
				if (_isDirectional == value)
				{
					return;
				}
				_isDirectional = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("aimAssistData")] 
		public CArray<TweakDBID> AimAssistData
		{
			get
			{
				if (_aimAssistData == null)
				{
					_aimAssistData = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "aimAssistData", cr2w, this);
				}
				return _aimAssistData;
			}
			set
			{
				if (_aimAssistData == value)
				{
					return;
				}
				_aimAssistData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("alwaysInTestRange")] 
		public CBool AlwaysInTestRange
		{
			get
			{
				if (_alwaysInTestRange == null)
				{
					_alwaysInTestRange = (CBool) CR2WTypeManager.Create("Bool", "alwaysInTestRange", cr2w, this);
				}
				return _alwaysInTestRange;
			}
			set
			{
				if (_alwaysInTestRange == value)
				{
					return;
				}
				_alwaysInTestRange = value;
				PropertySet(this);
			}
		}

		public gameTargetingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
