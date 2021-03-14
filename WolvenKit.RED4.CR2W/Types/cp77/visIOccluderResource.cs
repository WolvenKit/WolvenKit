using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class visIOccluderResource : ISerializable
	{
		private CUInt32 _resourceHash;

		[Ordinal(0)] 
		[RED("resourceHash")] 
		public CUInt32 ResourceHash
		{
			get
			{
				if (_resourceHash == null)
				{
					_resourceHash = (CUInt32) CR2WTypeManager.Create("Uint32", "resourceHash", cr2w, this);
				}
				return _resourceHash;
			}
			set
			{
				if (_resourceHash == value)
				{
					return;
				}
				_resourceHash = value;
				PropertySet(this);
			}
		}

		public visIOccluderResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
