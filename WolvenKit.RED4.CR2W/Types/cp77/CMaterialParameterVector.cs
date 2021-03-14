using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterVector : CMaterialParameter
	{
		private Vector4 _vector;

		[Ordinal(2)] 
		[RED("vector")] 
		public Vector4 Vector
		{
			get
			{
				if (_vector == null)
				{
					_vector = (Vector4) CR2WTypeManager.Create("Vector4", "vector", cr2w, this);
				}
				return _vector;
			}
			set
			{
				if (_vector == value)
				{
					return;
				}
				_vector = value;
				PropertySet(this);
			}
		}

		public CMaterialParameterVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
