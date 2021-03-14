using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAdditionalTransformEntry : ISerializable
	{
		private animTransformInfo _transformInfo;
		private QsTransform _value;

		[Ordinal(0)] 
		[RED("transformInfo")] 
		public animTransformInfo TransformInfo
		{
			get
			{
				if (_transformInfo == null)
				{
					_transformInfo = (animTransformInfo) CR2WTypeManager.Create("animTransformInfo", "transformInfo", cr2w, this);
				}
				return _transformInfo;
			}
			set
			{
				if (_transformInfo == value)
				{
					return;
				}
				_transformInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public QsTransform Value
		{
			get
			{
				if (_value == null)
				{
					_value = (QsTransform) CR2WTypeManager.Create("QsTransform", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public animAdditionalTransformEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
