namespace Flow.Launcher.Plugin.Engineering.XNoteFinder
{


    public class Main : IPlugin
    {
        public List<Record> Records { get; } = new List<Record>();

        public void Init(PluginInitContext context)
        {
            Records.AddRange(MySQLHelper.RetrieveAllRecords());
        }

        public List<Result> Query(Query query)
        {
            List<Result> results = new List<Result>();

            foreach (Record item in Records)
            {
                if (query.SearchTerms.All(item.Content!.Contains))
                {
                    results.Add(
                        new Result
                        {
                            Title = item.Content,
                            CopyText = item.Content,
                            SubTitle = $"{item.Code}  {item.Clause}",
                            Action = x =>
                            {
                                string imagePath = string.Empty;

                                //if (item.ImageFlag != 0)
                                //{
                                //    byte[] buffer = MySQLHelper.ViewImage(item.Id);
                                //    if (buffer.Length > 0)
                                //    {
                                //        imagePath = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), Guid.NewGuid().ToString());
                                //        imagePath += ".png";
                                //        ImageHelper.BytesToImage(buffer, imagePath);
                                //    }
                                //}

                                return true;
                            }
                        });
                }
            }

            return results;
        }
    }
}