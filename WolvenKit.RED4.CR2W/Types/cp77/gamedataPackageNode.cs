using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataPackageNode : ISerializable
	{
		private CString _name;
		private CArray<CHandle<gamedataVariableNode>> _serializedVariables;
		private CArray<CHandle<gamedataGroupNode>> _serializedGroups;
		private CArray<CHandle<gamedataFileNode>> _files;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("serializedVariables")] 
		public CArray<CHandle<gamedataVariableNode>> SerializedVariables
		{
			get => GetProperty(ref _serializedVariables);
			set => SetProperty(ref _serializedVariables, value);
		}

		[Ordinal(2)] 
		[RED("serializedGroups")] 
		public CArray<CHandle<gamedataGroupNode>> SerializedGroups
		{
			get => GetProperty(ref _serializedGroups);
			set => SetProperty(ref _serializedGroups, value);
		}

		[Ordinal(3)] 
		[RED("files")] 
		public CArray<CHandle<gamedataFileNode>> Files
		{
			get => GetProperty(ref _files);
			set => SetProperty(ref _files, value);
		}

		public gamedataPackageNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
