export async function FetchData() {
    const response = await fetch('http://localhost:5007/api/v1/hello');
    // const data = await response.json();
    const data = await response.text();
    return data;
}
