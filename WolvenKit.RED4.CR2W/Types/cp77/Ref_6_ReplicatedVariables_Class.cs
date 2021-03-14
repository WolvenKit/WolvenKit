using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_6_ReplicatedVariables_Class : IScriptable
	{
		private CInt32 _thisIsReplicatedFieldInClass;

		[Ordinal(0)] 
		[RED("thisIsReplicatedFieldInClass")] 
		public CInt32 ThisIsReplicatedFieldInClass
		{
			get
			{
				if (_thisIsReplicatedFieldInClass == null)
				{
					_thisIsReplicatedFieldInClass = (CInt32) CR2WTypeManager.Create("Int32", "thisIsReplicatedFieldInClass", cr2w, this);
				}
				return _thisIsReplicatedFieldInClass;
			}
			set
			{
				if (_thisIsReplicatedFieldInClass == value)
				{
					return;
				}
				_thisIsReplicatedFieldInClass = value;
				PropertySet(this);
			}
		}

		public Ref_6_ReplicatedVariables_Class(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
