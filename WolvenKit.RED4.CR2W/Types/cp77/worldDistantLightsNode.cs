using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDistantLightsNode : worldNode
	{
		private raRef<CDistantLightsResource> _data;

		[Ordinal(4)] 
		[RED("data")] 
		public raRef<CDistantLightsResource> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (raRef<CDistantLightsResource>) CR2WTypeManager.Create("raRef:CDistantLightsResource", "data", cr2w, this);
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

		public worldDistantLightsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
