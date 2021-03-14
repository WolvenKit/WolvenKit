using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealDeviceRequest : redEvent
	{
		private CBool _shouldReveal;
		private entEntityID _sourceID;
		private SNetworkLinkData _linkData;

		[Ordinal(0)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get
			{
				if (_shouldReveal == null)
				{
					_shouldReveal = (CBool) CR2WTypeManager.Create("Bool", "shouldReveal", cr2w, this);
				}
				return _shouldReveal;
			}
			set
			{
				if (_shouldReveal == value)
				{
					return;
				}
				_shouldReveal = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get
			{
				if (_sourceID == null)
				{
					_sourceID = (entEntityID) CR2WTypeManager.Create("entEntityID", "sourceID", cr2w, this);
				}
				return _sourceID;
			}
			set
			{
				if (_sourceID == value)
				{
					return;
				}
				_sourceID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("linkData")] 
		public SNetworkLinkData LinkData
		{
			get
			{
				if (_linkData == null)
				{
					_linkData = (SNetworkLinkData) CR2WTypeManager.Create("SNetworkLinkData", "linkData", cr2w, this);
				}
				return _linkData;
			}
			set
			{
				if (_linkData == value)
				{
					return;
				}
				_linkData = value;
				PropertySet(this);
			}
		}

		public RevealDeviceRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
