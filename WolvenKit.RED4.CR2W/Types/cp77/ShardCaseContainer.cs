using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCaseContainer : gameContainerObjectSingleItem
	{
		private CBool _wasOpened;
		private CHandle<entMeshComponent> _shardMesh;

		[Ordinal(52)] 
		[RED("wasOpened")] 
		public CBool WasOpened
		{
			get
			{
				if (_wasOpened == null)
				{
					_wasOpened = (CBool) CR2WTypeManager.Create("Bool", "wasOpened", cr2w, this);
				}
				return _wasOpened;
			}
			set
			{
				if (_wasOpened == value)
				{
					return;
				}
				_wasOpened = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("shardMesh")] 
		public CHandle<entMeshComponent> ShardMesh
		{
			get
			{
				if (_shardMesh == null)
				{
					_shardMesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "shardMesh", cr2w, this);
				}
				return _shardMesh;
			}
			set
			{
				if (_shardMesh == value)
				{
					return;
				}
				_shardMesh = value;
				PropertySet(this);
			}
		}

		public ShardCaseContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
