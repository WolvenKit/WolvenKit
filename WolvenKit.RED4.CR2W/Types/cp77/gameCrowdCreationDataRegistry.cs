using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdCreationDataRegistry : ISerializable
	{
		private CArray<gameCrowdCreationData> _creationData;

		[Ordinal(0)] 
		[RED("creationData")] 
		public CArray<gameCrowdCreationData> CreationData
		{
			get => GetProperty(ref _creationData);
			set => SetProperty(ref _creationData, value);
		}

		public gameCrowdCreationDataRegistry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
