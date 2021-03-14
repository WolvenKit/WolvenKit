using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleCollisionMapItem : CVariable
	{
		private CName _name;
		private CName _impactEvent;
		private CName _scrapingLoopStart;
		private CName _scrapingLoopEnd;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("impactEvent")] 
		public CName ImpactEvent
		{
			get
			{
				if (_impactEvent == null)
				{
					_impactEvent = (CName) CR2WTypeManager.Create("CName", "impactEvent", cr2w, this);
				}
				return _impactEvent;
			}
			set
			{
				if (_impactEvent == value)
				{
					return;
				}
				_impactEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scrapingLoopStart")] 
		public CName ScrapingLoopStart
		{
			get
			{
				if (_scrapingLoopStart == null)
				{
					_scrapingLoopStart = (CName) CR2WTypeManager.Create("CName", "scrapingLoopStart", cr2w, this);
				}
				return _scrapingLoopStart;
			}
			set
			{
				if (_scrapingLoopStart == value)
				{
					return;
				}
				_scrapingLoopStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("scrapingLoopEnd")] 
		public CName ScrapingLoopEnd
		{
			get
			{
				if (_scrapingLoopEnd == null)
				{
					_scrapingLoopEnd = (CName) CR2WTypeManager.Create("CName", "scrapingLoopEnd", cr2w, this);
				}
				return _scrapingLoopEnd;
			}
			set
			{
				if (_scrapingLoopEnd == value)
				{
					return;
				}
				_scrapingLoopEnd = value;
				PropertySet(this);
			}
		}

		public audioVehicleCollisionMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
