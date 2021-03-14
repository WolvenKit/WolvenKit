using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterNetworkLinkBetweenTwoEntitiesRequest : gameScriptableSystemRequest
	{
		private entEntityID _firstID;
		private entEntityID _secondID;
		private CBool _onlyRemoveWeakLink;

		[Ordinal(0)] 
		[RED("firstID")] 
		public entEntityID FirstID
		{
			get
			{
				if (_firstID == null)
				{
					_firstID = (entEntityID) CR2WTypeManager.Create("entEntityID", "firstID", cr2w, this);
				}
				return _firstID;
			}
			set
			{
				if (_firstID == value)
				{
					return;
				}
				_firstID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("secondID")] 
		public entEntityID SecondID
		{
			get
			{
				if (_secondID == null)
				{
					_secondID = (entEntityID) CR2WTypeManager.Create("entEntityID", "secondID", cr2w, this);
				}
				return _secondID;
			}
			set
			{
				if (_secondID == value)
				{
					return;
				}
				_secondID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("onlyRemoveWeakLink")] 
		public CBool OnlyRemoveWeakLink
		{
			get
			{
				if (_onlyRemoveWeakLink == null)
				{
					_onlyRemoveWeakLink = (CBool) CR2WTypeManager.Create("Bool", "onlyRemoveWeakLink", cr2w, this);
				}
				return _onlyRemoveWeakLink;
			}
			set
			{
				if (_onlyRemoveWeakLink == value)
				{
					return;
				}
				_onlyRemoveWeakLink = value;
				PropertySet(this);
			}
		}

		public UnregisterNetworkLinkBetweenTwoEntitiesRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
