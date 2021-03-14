using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_StaticVector : animIAnimNodeSourceChannel_Vector
	{
		private Vector4 _data;

		[Ordinal(0)] 
		[RED("data")] 
		public Vector4 Data
		{
			get
			{
				if (_data == null)
				{
					_data = (Vector4) CR2WTypeManager.Create("Vector4", "data", cr2w, this);
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

		public animAnimNodeSourceChannel_StaticVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
