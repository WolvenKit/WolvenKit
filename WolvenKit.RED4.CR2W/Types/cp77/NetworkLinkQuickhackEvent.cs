using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkLinkQuickhackEvent : redEvent
	{
		private entEntityID _netrunnerID;
		private entEntityID _proxyID;
		private entEntityID _targetID;
		private entEntityID _from;
		private entEntityID _to;

		[Ordinal(0)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get
			{
				if (_netrunnerID == null)
				{
					_netrunnerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "netrunnerID", cr2w, this);
				}
				return _netrunnerID;
			}
			set
			{
				if (_netrunnerID == value)
				{
					return;
				}
				_netrunnerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("proxyID")] 
		public entEntityID ProxyID
		{
			get
			{
				if (_proxyID == null)
				{
					_proxyID = (entEntityID) CR2WTypeManager.Create("entEntityID", "proxyID", cr2w, this);
				}
				return _proxyID;
			}
			set
			{
				if (_proxyID == value)
				{
					return;
				}
				_proxyID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("from")] 
		public entEntityID From
		{
			get
			{
				if (_from == null)
				{
					_from = (entEntityID) CR2WTypeManager.Create("entEntityID", "from", cr2w, this);
				}
				return _from;
			}
			set
			{
				if (_from == value)
				{
					return;
				}
				_from = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("to")] 
		public entEntityID To
		{
			get
			{
				if (_to == null)
				{
					_to = (entEntityID) CR2WTypeManager.Create("entEntityID", "to", cr2w, this);
				}
				return _to;
			}
			set
			{
				if (_to == value)
				{
					return;
				}
				_to = value;
				PropertySet(this);
			}
		}

		public NetworkLinkQuickhackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
