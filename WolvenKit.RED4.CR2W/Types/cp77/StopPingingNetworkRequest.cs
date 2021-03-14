using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopPingingNetworkRequest : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _source;
		private CHandle<PingCachedData> _pingData;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pingData")] 
		public CHandle<PingCachedData> PingData
		{
			get
			{
				if (_pingData == null)
				{
					_pingData = (CHandle<PingCachedData>) CR2WTypeManager.Create("handle:PingCachedData", "pingData", cr2w, this);
				}
				return _pingData;
			}
			set
			{
				if (_pingData == value)
				{
					return;
				}
				_pingData = value;
				PropertySet(this);
			}
		}

		public StopPingingNetworkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
