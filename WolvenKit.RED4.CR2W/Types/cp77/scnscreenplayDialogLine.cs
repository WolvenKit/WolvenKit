using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayDialogLine : CVariable
	{
		private scnscreenplayItemId _itemId;
		private scnActorId _speaker;
		private scnActorId _addressee;
		private scnscreenplayLineUsage _usage;
		private scnlocLocstringId _locstringId;
		private CName _maleLipsyncAnimationName;
		private CName _femaleLipsyncAnimationName;

		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (scnscreenplayItemId) CR2WTypeManager.Create("scnscreenplayItemId", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("speaker")] 
		public scnActorId Speaker
		{
			get
			{
				if (_speaker == null)
				{
					_speaker = (scnActorId) CR2WTypeManager.Create("scnActorId", "speaker", cr2w, this);
				}
				return _speaker;
			}
			set
			{
				if (_speaker == value)
				{
					return;
				}
				_speaker = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("addressee")] 
		public scnActorId Addressee
		{
			get
			{
				if (_addressee == null)
				{
					_addressee = (scnActorId) CR2WTypeManager.Create("scnActorId", "addressee", cr2w, this);
				}
				return _addressee;
			}
			set
			{
				if (_addressee == value)
				{
					return;
				}
				_addressee = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("usage")] 
		public scnscreenplayLineUsage Usage
		{
			get
			{
				if (_usage == null)
				{
					_usage = (scnscreenplayLineUsage) CR2WTypeManager.Create("scnscreenplayLineUsage", "usage", cr2w, this);
				}
				return _usage;
			}
			set
			{
				if (_usage == value)
				{
					return;
				}
				_usage = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("locstringId")] 
		public scnlocLocstringId LocstringId
		{
			get
			{
				if (_locstringId == null)
				{
					_locstringId = (scnlocLocstringId) CR2WTypeManager.Create("scnlocLocstringId", "locstringId", cr2w, this);
				}
				return _locstringId;
			}
			set
			{
				if (_locstringId == value)
				{
					return;
				}
				_locstringId = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maleLipsyncAnimationName")] 
		public CName MaleLipsyncAnimationName
		{
			get
			{
				if (_maleLipsyncAnimationName == null)
				{
					_maleLipsyncAnimationName = (CName) CR2WTypeManager.Create("CName", "maleLipsyncAnimationName", cr2w, this);
				}
				return _maleLipsyncAnimationName;
			}
			set
			{
				if (_maleLipsyncAnimationName == value)
				{
					return;
				}
				_maleLipsyncAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("femaleLipsyncAnimationName")] 
		public CName FemaleLipsyncAnimationName
		{
			get
			{
				if (_femaleLipsyncAnimationName == null)
				{
					_femaleLipsyncAnimationName = (CName) CR2WTypeManager.Create("CName", "femaleLipsyncAnimationName", cr2w, this);
				}
				return _femaleLipsyncAnimationName;
			}
			set
			{
				if (_femaleLipsyncAnimationName == value)
				{
					return;
				}
				_femaleLipsyncAnimationName = value;
				PropertySet(this);
			}
		}

		public scnscreenplayDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
