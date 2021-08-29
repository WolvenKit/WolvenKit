using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entIComponent : IScriptable
	{
		private CName _name;
		private CBool _isReplicable;
		private CRUID _id;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("isReplicable")] 
		public CBool IsReplicable
		{
			get => GetProperty(ref _isReplicable);
			set => SetProperty(ref _isReplicable, value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
