using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootResource : CResource
	{
		private CHandle<gameLootResourceData> _data;

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameLootResourceData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<gameLootResourceData>) CR2WTypeManager.Create("handle:gameLootResourceData", "data", cr2w, this);
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

		public gameLootResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
