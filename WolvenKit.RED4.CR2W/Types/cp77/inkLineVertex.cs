using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLineVertex : CVariable
	{
		private Vector2 _int;
		private CEnum<inkLineType> _neType;

		[Ordinal(0)] 
		[RED("int")] 
		public Vector2 Int
		{
			get
			{
				if (_int == null)
				{
					_int = (Vector2) CR2WTypeManager.Create("Vector2", "int", cr2w, this);
				}
				return _int;
			}
			set
			{
				if (_int == value)
				{
					return;
				}
				_int = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("neType")] 
		public CEnum<inkLineType> NeType
		{
			get
			{
				if (_neType == null)
				{
					_neType = (CEnum<inkLineType>) CR2WTypeManager.Create("inkLineType", "neType", cr2w, this);
				}
				return _neType;
			}
			set
			{
				if (_neType == value)
				{
					return;
				}
				_neType = value;
				PropertySet(this);
			}
		}

		public inkLineVertex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
