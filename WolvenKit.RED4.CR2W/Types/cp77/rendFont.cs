using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendFont : CResource
	{
		private DataBuffer _fontBuffer;

		[Ordinal(1)] 
		[RED("fontBuffer")] 
		public DataBuffer FontBuffer
		{
			get
			{
				if (_fontBuffer == null)
				{
					_fontBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "fontBuffer", cr2w, this);
				}
				return _fontBuffer;
			}
			set
			{
				if (_fontBuffer == value)
				{
					return;
				}
				_fontBuffer = value;
				PropertySet(this);
			}
		}

		public rendFont(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
