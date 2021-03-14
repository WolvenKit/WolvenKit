using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedVisibilityInAnimSystemRequest : gameScriptableSystemRequest
	{
		private CHandle<ForcedVisibilityInAnimSystemData> _data;
		private CBool _isVisible;
		private entEntityID _entityID;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<ForcedVisibilityInAnimSystemData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<ForcedVisibilityInAnimSystemData>) CR2WTypeManager.Create("handle:ForcedVisibilityInAnimSystemData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CBool) CR2WTypeManager.Create("Bool", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		public DelayedVisibilityInAnimSystemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
