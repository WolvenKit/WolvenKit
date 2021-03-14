using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProtectedEntities : MorphData
	{
		private CArray<entEntityID> _protectedEntities;

		[Ordinal(1)] 
		[RED("protectedEntities")] 
		public CArray<entEntityID> ProtectedEntities_
		{
			get
			{
				if (_protectedEntities == null)
				{
					_protectedEntities = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "protectedEntities", cr2w, this);
				}
				return _protectedEntities;
			}
			set
			{
				if (_protectedEntities == value)
				{
					return;
				}
				_protectedEntities = value;
				PropertySet(this);
			}
		}

		public ProtectedEntities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
