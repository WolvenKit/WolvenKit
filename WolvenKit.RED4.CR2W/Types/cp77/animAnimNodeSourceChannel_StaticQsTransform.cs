using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_StaticQsTransform : animIAnimNodeSourceChannel_QsTransform
	{
		private QsTransform _data;

		[Ordinal(0)] 
		[RED("data")] 
		public QsTransform Data
		{
			get
			{
				if (_data == null)
				{
					_data = (QsTransform) CR2WTypeManager.Create("QsTransform", "data", cr2w, this);
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

		public animAnimNodeSourceChannel_StaticQsTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
