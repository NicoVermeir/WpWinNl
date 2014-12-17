﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.Storage;

namespace WpWinNl.Utilities
{

  /// <summary>
  /// Replaces the missing TryGetItemAsync method in Windows Phone 8.1
  /// </summary>
  public static class StorageFolderExtensions
  {
    public static async Task<IStorageItem> TryGetItemAsync(this StorageFolder folder, string name)
    {
      var files = await folder.GetItemsAsync().AsTask().ConfigureAwait(false);
      return files.FirstOrDefault(p => p.Name == name);
    }
  }
}