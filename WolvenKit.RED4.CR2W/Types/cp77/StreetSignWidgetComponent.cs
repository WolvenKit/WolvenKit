using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StreetSignWidgetComponent : IWorldWidgetComponent
	{
		private TweakDBID _streetSignTDBID;
		private CBool _isAStreetName;
		private TweakDBID _streetNameSignTDBID;
		private CHandle<inkTweakDBIDSelector> _signSelector;
		private CUInt32 _signVersion;

		[Ordinal(10)] 
		[RED("streetSignTDBID")] 
		public TweakDBID StreetSignTDBID
		{
			get
			{
				if (_streetSignTDBID == null)
				{
					_streetSignTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "streetSignTDBID", cr2w, this);
				}
				return _streetSignTDBID;
			}
			set
			{
				if (_streetSignTDBID == value)
				{
					return;
				}
				_streetSignTDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isAStreetName")] 
		public CBool IsAStreetName
		{
			get
			{
				if (_isAStreetName == null)
				{
					_isAStreetName = (CBool) CR2WTypeManager.Create("Bool", "isAStreetName", cr2w, this);
				}
				return _isAStreetName;
			}
			set
			{
				if (_isAStreetName == value)
				{
					return;
				}
				_isAStreetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("streetNameSignTDBID")] 
		public TweakDBID StreetNameSignTDBID
		{
			get
			{
				if (_streetNameSignTDBID == null)
				{
					_streetNameSignTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "streetNameSignTDBID", cr2w, this);
				}
				return _streetNameSignTDBID;
			}
			set
			{
				if (_streetNameSignTDBID == value)
				{
					return;
				}
				_streetNameSignTDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("signSelector")] 
		public CHandle<inkTweakDBIDSelector> SignSelector
		{
			get
			{
				if (_signSelector == null)
				{
					_signSelector = (CHandle<inkTweakDBIDSelector>) CR2WTypeManager.Create("handle:inkTweakDBIDSelector", "signSelector", cr2w, this);
				}
				return _signSelector;
			}
			set
			{
				if (_signSelector == value)
				{
					return;
				}
				_signSelector = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("signVersion")] 
		public CUInt32 SignVersion
		{
			get
			{
				if (_signVersion == null)
				{
					_signVersion = (CUInt32) CR2WTypeManager.Create("Uint32", "signVersion", cr2w, this);
				}
				return _signVersion;
			}
			set
			{
				if (_signVersion == value)
				{
					return;
				}
				_signVersion = value;
				PropertySet(this);
			}
		}

		public StreetSignWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
