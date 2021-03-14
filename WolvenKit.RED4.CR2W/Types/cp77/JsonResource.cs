using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JsonResource : CResource
	{
		private CHandle<ISerializable> _root;

		[Ordinal(1)] 
		[RED("root")] 
		public CHandle<ISerializable> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<ISerializable>) CR2WTypeManager.Create("handle:ISerializable", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		public JsonResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
