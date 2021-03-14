using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotItemOverrideItemOverride : CVariable
	{
		private TweakDBID _prevItemId;
		private TweakDBID _newItemId;

		[Ordinal(0)] 
		[RED("prevItemId")] 
		public TweakDBID PrevItemId
		{
			get
			{
				if (_prevItemId == null)
				{
					_prevItemId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "prevItemId", cr2w, this);
				}
				return _prevItemId;
			}
			set
			{
				if (_prevItemId == value)
				{
					return;
				}
				_prevItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("newItemId")] 
		public TweakDBID NewItemId
		{
			get
			{
				if (_newItemId == null)
				{
					_newItemId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "newItemId", cr2w, this);
				}
				return _newItemId;
			}
			set
			{
				if (_newItemId == value)
				{
					return;
				}
				_newItemId = value;
				PropertySet(this);
			}
		}

		public workWorkspotItemOverrideItemOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
