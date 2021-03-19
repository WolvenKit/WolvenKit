using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Entity : questTimeDilation_NodeTypeParam
	{
		private CHandle<questTimeDilation_Operation> _operation;
		private CEnum<questETimeDilationOverride> _globalTimeDilationOverride;
		private CEnum<questETimeDilationOverride> _parentTimeDilationOverride;
		private CArray<NodeRef> _entities;

		[Ordinal(0)] 
		[RED("operation")] 
		public CHandle<questTimeDilation_Operation> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(1)] 
		[RED("globalTimeDilationOverride")] 
		public CEnum<questETimeDilationOverride> GlobalTimeDilationOverride
		{
			get => GetProperty(ref _globalTimeDilationOverride);
			set => SetProperty(ref _globalTimeDilationOverride, value);
		}

		[Ordinal(2)] 
		[RED("parentTimeDilationOverride")] 
		public CEnum<questETimeDilationOverride> ParentTimeDilationOverride
		{
			get => GetProperty(ref _parentTimeDilationOverride);
			set => SetProperty(ref _parentTimeDilationOverride, value);
		}

		[Ordinal(3)] 
		[RED("entities")] 
		public CArray<NodeRef> Entities
		{
			get => GetProperty(ref _entities);
			set => SetProperty(ref _entities, value);
		}

		public questTimeDilation_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
