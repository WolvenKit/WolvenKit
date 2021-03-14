using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSequenceTargetInfo : ISerializable
	{
		private CArray<CUInt32> _path;

		[Ordinal(0)] 
		[RED("path")] 
		public CArray<CUInt32> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		public inkanimSequenceTargetInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
