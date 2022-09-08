using EasyCollection.Tasks.ArrayTasks;
using EasyCollection.Tasks.IntegerTasks;
using EasyCollection.Tasks.StringTasks;

var list = new List<int[]>()
{
    new int[] {1,0,2}, new int[] {1,3,4}, new int[] {1,2,3}
};
new RotateImageTask(list).Do();