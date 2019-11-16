function range(start, edge, step) {
  if (arguments.length === 1) {
    edge = start;
    start = 0;
  }

  edge = edge || 0;
  step = step || 1;

  let arr = [];
  for (arr; (edge - start) * step > 0; start += step) {
    arr.push(start);
  }
  return arr;
}
