using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTransferItems_NodeTypeParams_TransferAllOperationData : ISerializable
	{
		private CArray<TweakDBID> _itemIDsToIgnore;
		private CArray<CName> _tagsToIgnore;

		[Ordinal(0)] 
		[RED("itemIDsToIgnore")] 
		public CArray<TweakDBID> ItemIDsToIgnore
		{
			get
			{
				if (_itemIDsToIgnore == null)
				{
					_itemIDsToIgnore = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "itemIDsToIgnore", cr2w, this);
				}
				return _itemIDsToIgnore;
			}
			set
			{
				if (_itemIDsToIgnore == value)
				{
					return;
				}
				_itemIDsToIgnore = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tagsToIgnore")] 
		public CArray<CName> TagsToIgnore
		{
			get
			{
				if (_tagsToIgnore == null)
				{
					_tagsToIgnore = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tagsToIgnore", cr2w, this);
				}
				return _tagsToIgnore;
			}
			set
			{
				if (_tagsToIgnore == value)
				{
					return;
				}
				_tagsToIgnore = value;
				PropertySet(this);
			}
		}

		public questTransferItems_NodeTypeParams_TransferAllOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
