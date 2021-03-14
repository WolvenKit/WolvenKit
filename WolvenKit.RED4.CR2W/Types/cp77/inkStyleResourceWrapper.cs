using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleResourceWrapper : ISerializable
	{
		private raRef<inkStyleResource> _styleResource;

		[Ordinal(0)] 
		[RED("styleResource")] 
		public raRef<inkStyleResource> StyleResource
		{
			get
			{
				if (_styleResource == null)
				{
					_styleResource = (raRef<inkStyleResource>) CR2WTypeManager.Create("raRef:inkStyleResource", "styleResource", cr2w, this);
				}
				return _styleResource;
			}
			set
			{
				if (_styleResource == value)
				{
					return;
				}
				_styleResource = value;
				PropertySet(this);
			}
		}

		public inkStyleResourceWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
